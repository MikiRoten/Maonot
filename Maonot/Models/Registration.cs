using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Maonot.Models
{
    public enum Year
    {
        א, ב, ג, ד
    }
    public enum FieldStudy
    {
        מערכות_מידע,
        תקשורת,
        מדעי_ההתנהגות,
        תקשורת_חזותית,
        פסכולוגיה,
        קרימנולוגיה,
        סוציולוגיה_ואנטרפולוגיה,
        עבודה_סוציאלית,
        כלכלה_וניהול,
        שירותי_אנוש,
        חינוך,
        סיעוד,
        מדעי_המדינה,
        רב_תחומי_במדעי_החברה,
        מנהל_מערכות_בריאות,
        תואר_שני_םסיכולוגיה_חינוכית,
        תואר_שני_בפיתוח_ויעוץ_ארגוני,
        תואר_שני_ביעוץ_חינוכי,
        תואר_שני_במנהל_למערכות_בריאות,
        מכינה
    }
    public enum Service
    {
        צבאי,
        לאומי,
        אזרחי,
        פטור
    }
    public enum HealthCondition
    {
        נכה_צהל,
        נכות,
        מגבלה_פיזית_אחרת,
        ללא_מגבלה
    }
    public enum ApertmantType
    {
        יחיד,
        זוגי
    }
    public class Registration
    {
        public int ID { get; set; }
        public int StundetId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public User User { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Bday { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public FieldStudy? FieldOfStudy { get; set; }
        public Year? SteadyYear { get; set; }
        public Service? TypeOfService { get; set; }
        public HealthCondition? HealthCondition { get; set; }
        public Year? Seniority { get; set; }
        public ApertmantType? ApertmantType { get; set; }
        // להוסיף אפשרות לצרף מסמכים לשדות חייל בודד, שרות צבאי, ומגבלות רפואיות
        // יש אפשרות לצרף מסמכי תעודת זהות של ההורים
        // יצירת טבלה דינמית שמאפשרת להוסיף הורים\אחים ולתת עליהם את הנתונים הרלוונטים
        public int PartnerID { get; set; }
        public int PartnerLastName { get; set; }
        public int PartnerFirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PartnerBday { get; set; }
        // אפשרות לצירוף מסמכים על בן\בת הזוג
        // צרוף מסמכים על על הכנסת הורים
        //צירוף מכתב אישי








    }
}
