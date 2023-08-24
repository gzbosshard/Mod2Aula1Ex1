internal class Program
{
    private static void Main(string[] args)
    {

    }
}

public abstract class Funcionario
{
    public abstract void GetBonificacao();
}

public abstract class Secretaria
{

}

public class SecretariaAdministrativa : Secretaria
{

}

public class SecretariaAgencia : Secretaria
{

}

public class Presidente : Funcionario
{
    public override void GetBonificacao()
    {
        //..
    }
}

public class Gerente : Funcionario
{
    public override void GetBonificacao()
    {
        //..
    }
}

public class Diretor : Gerente
{

}