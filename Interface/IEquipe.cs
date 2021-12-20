using E_JOGOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_JOGOS.Interface
{
    interface IEquipe
    {
        void Create(Equipe nova_equipe);
        List<Equipe> ReadAll();
        void Update(Equipe equipe);
        void Delete(int idEquipe);
    }
}
