using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Text;

namespace UserMaintenance.Entities
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get
            {
                return string.Format(
                    "{0} {1}",
                    LastName,
                    FirstName);
            }
        }
    }
}
