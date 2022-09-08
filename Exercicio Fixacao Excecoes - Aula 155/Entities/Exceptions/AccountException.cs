using System;


namespace Exercicio_Fixacao_Excecoes___Aula_155.Entities.Exceptions
{
    class AccountException:ApplicationException
    {
        public AccountException(string message) : base(message)
        {

        }
    }
}
