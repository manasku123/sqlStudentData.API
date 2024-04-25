using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.ViewModels.ViewModels
{
    public class StudentModel
    {
        public int Id { get; set; }
        public Guid StudentId { get; set; }
        public string? Name { get; set; }
        public string? Class { get; set; }
        public int MarkObtained { get; set; }
        public List<SheetModel> StudentSheet { get; set; }
    }
}
