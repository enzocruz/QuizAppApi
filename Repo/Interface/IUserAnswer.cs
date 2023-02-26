using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Interface
{
    interface IUserAnswer<T> where T : class
    {
        bool isCorrect(int q_id, int q_opt, int q_ans);
    }
}
