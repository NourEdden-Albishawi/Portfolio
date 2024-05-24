using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entities
{
    public class Project
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public Project(Guid id, string title, string description, string imageurl)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.ImageURL = imageurl;
        }
        public Project() { }

    }
}
