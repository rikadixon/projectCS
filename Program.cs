using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class TransactionProcessor<TObject, TRequest>
    {
        private Func<TRequest, bool> check;
        private Func<TRequest, TObject> register;
        private Action<TObject> save;

        public TransactionProcessor(Func<TRequest, bool> check, Func<TRequest, TObject> register, Action<TObject> save)
        {
            this.check = check;
            this.register = register;
            this.save = save;
        }
        public TObject Process(TRequest userRequest)
        {
            if (!this.check(userRequest))
            {
                throw new ArgumentException();
            }

            var result = this.register(userRequest);

            this.save(result);

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
