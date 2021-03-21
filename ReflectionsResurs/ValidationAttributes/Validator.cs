

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();
            PropertyInfo[] propertyInfos = objType.GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                List<MyValidationAttribute> allMyAttribute = propertyInfo.GetCustomAttributes<MyValidationAttribute>().ToList();
                object propertyObj = propertyInfo.GetValue(obj);

                foreach (MyValidationAttribute myValidationAttribute in allMyAttribute)
                {
                    bool isValid = myValidationAttribute.IsValid(propertyObj);

                    if (!isValid)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

       
    }
}
