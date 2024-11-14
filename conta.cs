public class conta
{
    private double _saldo;

    public void SetSaldo(double s)
    {
        try
        {
            if (s >= 0)
            {
                _saldo = s;
            }
            else
            {
                throw new Exception("O saldo não pode ser negativo");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}