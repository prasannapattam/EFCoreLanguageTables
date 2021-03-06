﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageTables
{
    class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public EmployeeLanguageModel Language { get; set; }
    }
}
