using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T model)
        {
            using (PokemonContext pokemonContext = new PokemonContext())
            {
                pokemonContext.Set<T>().Add(model);
                pokemonContext.SaveChanges();
            }
                return "Criado";

        }
        public virtual string Update(T model)
        {
            return "Alterado";
        }
        public virtual string Delete(int id)
        {
            return "Deletado";
        }
        public virtual T GetById(int id)
        {
            T model = null;
            return model;
        }
        public virtual List<T> GetAll()
        {
       
            List<T> list = new List<T>();
            using (PokemonContext pokemonContext = new PokemonContext())
            {
                list = pokemonContext.Set<T>().ToList();
            }
            return list;
        }
    }
}
