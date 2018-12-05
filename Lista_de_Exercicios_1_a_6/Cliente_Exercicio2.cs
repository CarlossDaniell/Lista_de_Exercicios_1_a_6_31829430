namespace Lista_de_Exercicios_1_a_6
{
    internal class Cliente_Exercicio2
    {
        //Atributos
        private int saldo;
        private int conta;
        private int totalCobrancas;
        private int totalCredito;
        private int limiteCredito;

        //Construtor padrão
        //Construtor utiliza o mesmo nome da classe
        public Cliente_Exercicio2()
        {
            //Aqui dentro faremos a inicialização dos atributos da classe

            saldo = 0;
            conta = 0;
            totalCobrancas = 0;
            totalCredito = 0;
            limiteCredito = 0;
        }

        //Construtor com valores do usuário
        //Utiliza o mesmo nome da classe

        public Cliente_Exercicio2(int saldo, int conta, int totalCobrancas, int totalCredito, int limiteCredito)
        {
            this.saldo = saldo;
            this.conta = conta;
            this.totalCobrancas = totalCobrancas;
            this.totalCredito = totalCredito;
            this.limiteCredito = limiteCredito;
        }

        //Método calcular novo saldo
        public int calcular_novo_saldo()
        {
            return this.saldo + this.totalCobrancas - this.totalCredito;
        }


        //Método atualizar saldo
        public void atualizar_saldo()
        {
            this.saldo = calcular_novo_saldo();
        }


        //Verificar limite ultrapassado
        public bool verificar_limite()
        {
            return this.saldo > this.limiteCredito;
        }
    }
}