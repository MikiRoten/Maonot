﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Maonot.Models
{
    public enum RoomType
    {
        חדר_ליחיד,
        דירה_זוגית_לשני_סטודנטים,
        דירה_זוגית_לסטונדנט_הנשוי_לשאינו_סטודנט,
        דירה_זוגית_לסטודנט_שבן_בת_הזוג_איננו_סטודנט
    }
    public enum Choose
    {
        מעוניין,
        לא_מעוניין,
        אפשרי
    }
    public enum Religious
    {
        יהודי,
        מוסלמי,
        נוצרי,
        דרוזי,
        אחר
    }
    public class ApprovalKit
    {
        public int ID { get; set; }
        public int StundetId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Registration Reg { get; set; }
        //public User User { get; set; }
        public RoomType? RoomType { get; set; }
        public Choose? LivingWithReligious { get; set; }
        public Choose? LivingWithSmoker { get; set; }
        public Religious? ReligiousType { get; set; }
        public string HealthCondition { get; set; }
        public int PartnerId1 { get; set; }
        public int PartnerId2 { get; set; }
        public int PartnerId3 { get; set; }
        public int PartnerId4 { get; set; }

        //הוספת אופציית העלאת נתונים







    }
}