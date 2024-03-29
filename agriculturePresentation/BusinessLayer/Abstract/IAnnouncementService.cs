﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        void IAnnouncementDalStatusToTrue(int id);
        void IAnnouncementDalStatusToFalse(int id); 
    }
}
