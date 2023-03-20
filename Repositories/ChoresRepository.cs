using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chores.Repositories;
    public class ChoresRepository
{
        private List<Chore> dbChores = new List<Chore>();
    

        public ChoresRepository(){
            dbChores.Add(new Chore(1, "Trash", 10, "Easy", false));
            dbChores.Add(new Chore(2, "Dishes", 20, "Medium", false));
            dbChores.Add(new Chore(3, "Lawn", 30, "Easy", false));
        }

        internal Chore CreateChore(Chore choreData){
            choreData.Id = dbChores[dbChores.Count - 1].Id + 1; 
            dbChores.Add(new Chore(choreData.Id, choreData.Name, choreData.Time, choreData.Difficulty, choreData.Finished));
            return choreData;
        }
        internal List<Chore> GetAllChores(){
            return dbChores;
        }

    internal bool RemoveChore(int choreId)
    {
        int count = dbChores.RemoveAll(c => c.Id == choreId);
        return count > 0;
    }
    internal Chore GetOneChore(int id){
        Chore chore = dbChores.Find(chore => chore.Id == id);
        return chore;
    }

}