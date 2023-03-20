using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chores.Services;
    public class ChoresService
{
    
        private readonly ChoresRepository _repo;

        public ChoresService(ChoresRepository repo)
        {
            _repo = repo;
        }

        public List<Chore> GetAllChores(){
            return _repo.GetAllChores();
        }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }
    internal Chore GetOneChore(int id){
        Chore chore = _repo.GetOneChore(id);
        if (chore == null)
        {
            throw new Exception("No bueno my friend");
        }
        return chore;
    }

    internal string RemoveChore(int choreId)
    {
        Chore chore = this.GetOneChore(choreId);
        bool result = _repo.RemoveChore(choreId);
        if (!result) throw new Exception("Didn't delete for who knows why");
        return $"{chore.Name} was removed";
    }
}