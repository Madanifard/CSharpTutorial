using CSharpTutorial.Helpers;

namespace CSharpTutorial;

class Program
{
    static void Main(String[] args)
    {
        var dataTypeObj = new DataTypeUtils();
        dataTypeObj.SampleDataType();
        dataTypeObj.SampleTypeCasting();
        dataTypeObj.SampleConverting();

        VariableUtils variableUtils = new();
        variableUtils.varibales();

        OperatorsUtils operatorsUtils = new();
        operatorsUtils.ArithmeticOperation();
        operatorsUtils.RelationalOperators();
        operatorsUtils.LogicalOperators();
        operatorsUtils.BitwiseOperator();
        operatorsUtils.AssignmentOperators();
        operatorsUtils.TernaryOperator();
        operatorsUtils.MiscellaneousOperators();
    }
}