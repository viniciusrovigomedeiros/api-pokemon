﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Data.Repository
{
    public interface IRepository<T> where T : BaseModel
 
    {
        string Create(T model);   
        string Update(T model);
        string Delete(int id);
        List<T> GetAll();
        T GetById(int id);    
    }
}
