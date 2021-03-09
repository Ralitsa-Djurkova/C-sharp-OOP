using AbstractsClassesAndInterfacesEx.Contracts;
using AbstractsClassesAndInterfacesEx.Exeptions;
using AbstractsClassesAndInterfacesEx.IO.Contracts;
using AbstractsClassesAndInterfacesEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private ICollection<ISoldier> soldiers;

        private Engine()
        {
            this.soldiers = new List<ISoldier>();
        }

        public Engine(IReader reader, IWriter writer):this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command;
            while ((command = this.reader.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string soldierType = cmdArg[0];
                int id = int.Parse(cmdArg[1]);
                string firstName = cmdArg[2];
                string lastname = cmdArg[3];

                ISoldier soldier = null;
                

                if(soldierType == "Private")
                {
                    soldier = AddPrivate(cmdArg, id, firstName, lastname);
                }
                else if(soldierType == "LieutenantGeneral")
                {
                    soldier = AddGeneral(cmdArg, id, firstName, lastname);
                }
                else if(soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(cmdArg[4]);
                    string corps = cmdArg[5];

                    try
                    {
                        IEngineer engineer = CreateEngineer(cmdArg, id, firstName, lastname, salary, corps);
                        soldier = engineer;
                    }
                    catch (InvalidCorpsExeption ice)
                    {
                        continue;
                    }

                }
                else if(soldierType == "Commando")
                {
                    decimal salary = decimal.Parse(cmdArg[4]);
                    string corps = cmdArg[5];

                    try
                    {
                        ICommando commando = GetCommando(cmdArg, id, firstName, lastname, salary, corps);

                        soldier = commando;
                    }
                    catch (InvalidCorpsExeption ise)
                    {

                        continue;
                    }
                }
                else if(soldierType == "Spy")
                {
                    int codeNumber = int.Parse(cmdArg[4]);

                    soldier = new Spy(id, firstName, lastname, codeNumber);
                }

                if(soldier != null)
                {
                    this.soldiers.Add(soldier);
                }
                
            }

            foreach (var soldier in this.soldiers)
            {
                this.writer.WriteLine(soldier.ToString()); ;
            }
        }

        private static ICommando GetCommando(string[] cmdArg, int id, string firstName, string lastname, decimal salary, string corps)
        {
            ICommando commando = new Commando(id, firstName, lastname, salary, corps);
            string[] missionsArg = cmdArg.Skip(6).ToArray();

            for (int i = 0; i < missionsArg.Length; i += 2)
            {
                try
                {
                    string missionCodeName = missionsArg[i];
                    string missionState = missionsArg[i + 1];

                    IMission mission = new Mission(missionCodeName, missionState);

                    commando.AddMission(mission);
                }
                catch (InvalidMissionStateExeption imse)
                {
                    continue;
                }

            }

            return commando;
        }

        private static IEngineer CreateEngineer(string[] cmdArg, int id, string firstName, string lastname, decimal salary, string corps)
        {
            IEngineer engineer = new Engineer(id, firstName, lastname, salary, corps);

            string[] repairArgs = cmdArg.Skip(6).ToArray();
            for (int i = 0; i < repairArgs.Length; i += 2)
            {
                string partName = repairArgs[i];
                int hoursWorked = int.Parse(repairArgs[i + 1]);

                IRepair repair = new Repair(partName, hoursWorked);

                engineer.AddRepair(repair);
            }

            return engineer;
        }

        private ISoldier AddGeneral(string[] cmdArg, int id, string firstName, string lastname)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(cmdArg[4]);
            ILieutenantGeneral general = new LieutenantGeneral(id, firstName, lastname, salary);

            foreach (var pid in cmdArg.Skip(5))
            {
                ISoldier privateToAdd = this.soldiers.First(p => p.Id == int.Parse(pid));

                general.AddPrivate(privateToAdd);
            }
            soldier = general;
            return soldier;
        }

        private static ISoldier AddPrivate(string[] cmdArg, int id, string firstName, string lastname)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(cmdArg[4]);
            soldier = new Private(id, firstName, lastname, salary);
            return soldier;
        }

        
    }
}
