using MyRes.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRes.Entities.Concrete
{
    public class UserResume:IEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int ResumeCategoryId { get; set; }
    }
}
