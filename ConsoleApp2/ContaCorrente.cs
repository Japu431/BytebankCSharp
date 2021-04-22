namespace ConsoleApp2
    {
        public class ContaCorrente
        {
            private int _agencia;
            private int _numero;

            public static int TotalDeContas { get; private set; }

            public Cliente Titular {get;set;}
            public int Agencia {
            get {
                 return _agencia;
            }
            set
            {
                if(value <= 0) {
                return;
                }
                _agencia = value;
            }
    }


            public int Numero {get;set;}
            private double _saldo = 100;

            public ContaCorrente(int agencia , int numero) {
                Agencia = agencia;
                Numero = numero;

                  TotalDeContas++;
          
            }

            public double Saldo {
                get {
                 return this._saldo;
                }
                set {
                  if(value < 0) {
                    return;
                } 
                else 
                 {
                    this._saldo = value;
                }
              }
            }


            public bool Sacar(double valor)
            {
                if (this._saldo < valor)
                {
                    return false;
                }
                else
                {
                    this._saldo -= valor;
                    return true;
                }

            }

            public void Depositar(double valor)
            {
                this._saldo += valor;
            }


            public bool Transferir(double valor, ContaCorrente contaDestinatario)
            {
                if (this._saldo < valor)
                {
                    return false;
                }

                this._saldo -= valor;
                contaDestinatario.Depositar(valor);
                return true;
            }
        }
    }
