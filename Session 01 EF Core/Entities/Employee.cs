using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_EF_Core.Entities
{
    // EF Core Support 4 Ways For Mapping Classes In Database (Table , View , Funcation)
    // 1. By Convention ---- ( Default Behaviour )
    // 2. Data Annotation ( Set of Attributes Used Data Validation )
    // 3. Fluent API ---- (Overrode OnModelCreating() )
    // 4. Class Configurations


    // POCO Class
    // Plained OLD CLR Object Class
    // 1. By Convention 
    //internal class Employee
    //{
    //    public int Id { get; set; } // Public Numeric Property 'id' or 'EmpolyeeId' --- PK Identity (1,1)

    //    public string? Name { get; set; } // Reference Type : Allow Null [Optional] nvarchar(max)

    //    public double Salary { get; set; } // Value Type : Not Allow Null - Float or Decimal

    //    public int? Age { get; set; } // Nullable<int> : Allow Nul [Optional]

    //    public string Address { get; set; }
    //}



    // 2. Data Annotation
    // هو هبيكون table اسمه --> Employees لما بيكون بال default بتاعت ال by convention
    // [Table("Employee" , Schema ="dbo")] //-------> لو عملت كدا هيتغر يبقي كدا
    //internal class Employee
    //{
    //    [Key] // عشان يكون parimary key --> EmpId
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]// طب انا مش عاوزه يكون identity --> هعمل كدا
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column(TypeName ="varchar")]
    //    [MaxLength(50)] // ممكن مستخدمش اللي فوق دي وهنا هيخليها nvarchar(50)
    //    [StringLength( 50 , MinimumLength = 10)]
    //    public string? Name { get; set; }


    //    [Column(TypeName ="money")]
    //    public double Salary { get; set; }

    //    [Required]
    //    [Range(20 , 60 )] // هنا عاوز الاعمار من 20 ل 60
    //    public int? Age { get; set; } 

    //    public string Address { get; set; }

    //    [Phone]
    //    public string Phone { get; set; }

    //    [EmailAddress]

    //    public string Email { get; set; }

    //    [NotMapped] // لو عاوز كله يتمثل في الداتا بيز الا ده اعمل كدا
    //    public double TotalSalary { get; set; }
    //}



    // 3. Fluent API
    internal class Employee
    {
        public int EmpId { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double TotalSalary { get; set; } 
    }
}
