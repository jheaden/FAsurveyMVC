using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FAsurveyintoMVC.Models
{
    public static partial class Lookups
    {
        public enum Frequency
        {
            [Description("1. Never")]
            Never = 1,
            [Description("2. Less than monthly")]
            LessThanMonthly,
            [Description("3. Once a month")]
            OnceAMonth,
            [Description("4. Two to three times a month")]
            _2to3TimesaMonth,
            [Description("5. Once a week")]
            OnceAWeek,
            [Description("6. Two to three times a week")]
            _2to3TimesAWeek,
            [Description("7. Four to six times a week")]
            _4to6TimesAWeek,
            [Description("8. Every day")]
            EveryDay
        };

        public static string GetDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute
                    = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                        as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }

        public enum Category
        {
            [Description("1. Substance taken in larger amount and for longer period than intended")]
            largerAmt = 1,
            [Description("2. Persistent desire or repeated unsuccessful attempts to quit")]
            cantQuit,
            [Description("3. Much time/activity to obtain, use, recover")]
            timeSpent,
            [Description("4. Important social, occupational, or recreational activities given up or reduced")]
            reducedActivities,
            [Description("5. Use continues despite knowledge of adverse consequences (e.g., emotional problems, physical problems)")]
            emotionalProblems,
            [Description("6. Tolerance (marked increase in amount; marked decrease in effect)")]
            tolerance,
            [Description("7.Characteristic withdrawal symptoms; substance taken to relieve withdrawal")]
            withdrawal,
            [Description("8. Continued use despite social or interpersonal problems")]
            socialProblems,
            [Description("9. Failure to fulfill major role obligation (e.g., work, school, home)")]
            roleFail,
            [Description("10. Use in physically hazardous situations")]
            hazardousSituations,
            [Description("11. Craving, or a strong desire or urge to use")]
            craving,
            [Description("12. Use causes clinically significant impairment or distress")]
            clinicalImpairment
        };
    }
}
