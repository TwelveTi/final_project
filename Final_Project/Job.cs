using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Job
    {
        public string Title { get; set; } // Tiêu đề công việc
        public string Company { get; set; } // Tên công ty
        public string Location { get; set; } // Vị trí
        public string Skills { get; set; } // Kỹ năng
                                           // ...

        public Job()
        {
            // Khởi tạo mặc định cho các thuộc tính.
        }

        public Job(string title, string company, string location, string skills)
        {
            Title = title;
            Company = company;
            Location = location;
            Skills = skills;
        }
    }
}
