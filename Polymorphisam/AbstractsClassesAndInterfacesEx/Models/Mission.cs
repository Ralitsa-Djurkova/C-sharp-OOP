using AbstractsClassesAndInterfacesEx.Contracts;
using AbstractsClassesAndInterfacesEx.Enumarations;
using AbstractsClassesAndInterfacesEx.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            this.State = this.TryparsState(state);
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMession()
        {
            if(this.State == State.Finished)
            {
                throw new InvalidMiisionaCompletionExeption();
            }

            this.State = State.Finished;
        }

        private State TryparsState(string stateStr)
        {
            bool parsed = Enum.TryParse(stateStr, out State state);

            if (!parsed)
            {
                throw new InvalidMissionStateExeption();
            }

            return state;
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State.ToString()}";
        }
    }
}
