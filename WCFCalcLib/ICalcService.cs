using System.ServiceModel;

namespace WCFCalcLib
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        double Add(double num1, double num2);

        [OperationContract]
        double Subtract(double num1, double num2);

        [OperationContract]
        double Multiply(double num1, double num2);

        [OperationContract]
        double Divide(double num1, double num2);
    }
}
