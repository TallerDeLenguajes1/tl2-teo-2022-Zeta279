namespace Taller2{
    interface ICuentaBancaria{
        void InsertarDinero(float monto);
        float ExtraerDinero(float monto);
    }

    class CuentaCorrientePesos: ICuentaBancaria{

        private float monto = 0;

        public float Monto { get => monto; set => monto = value; }
        private int tipo {get; set;}

        CuentaCorrientePesos(){
            Random rnd = new();
            tipo = rnd.Next(1, 3);
        }

        void ICuentaBancaria.InsertarDinero(float monto){
            this.monto += monto;
        }

        float ICuentaBancaria.ExtraerDinero(float monto){
            if(this.monto - monto < -5000 || tipo == 2 && monto > 20000){
                Console.WriteLine("No es posible extraer el dinero solicitado");
            }
            else{
                this.monto -= monto;
            }

            return monto;
        }
    }

    class CuentaCorrienteDolares: ICuentaBancaria{

        private float monto = 0;

        public float Monto { get => monto; set => monto = value; }
        private int tipo {get; set;}

        CuentaCorrienteDolares(){
            Random rnd = new();
            tipo = rnd.Next(1, 3);
        }

        void ICuentaBancaria.InsertarDinero(float monto){
            this.monto += monto;
        }

        float ICuentaBancaria.ExtraerDinero(float monto){
            if(this.monto - monto < 0 || tipo == 2 && monto > 200){
                Console.WriteLine("No es posible extraer el dinero solicitado");
            }
            else{
                this.monto -= monto;
            }

            return monto;
        }
    }

    class CuentaAhorroPesos: ICuentaBancaria{
        private float monto = 0;

        public float Monto { get => monto; set => monto = value; }
        private int tipo {get; set;}

        CuentaAhorroPesos(){
            Random rnd = new();
            tipo = rnd.Next(1, 3);
        }

        void ICuentaBancaria.InsertarDinero(float monto){
            this.monto += monto;
        }

        float ICuentaBancaria.ExtraerDinero(float monto){
            if(this.monto - monto < 0 || tipo == 2 && monto > 10000){
                Console.WriteLine("No es posible extraer el dinero solicitado");
            }
            else{
                this.monto -= monto;
            }

            return monto;
        }
    }
}