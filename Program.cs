using System;
using CSharpTutorial.Helpers;

namespace CSharpTutorial {
    class Program {
        static void Main(String[] args) {
            DataTypeUtils dataTypeObj = new DataTypeUtils();
            dataTypeObj.SampleDataType();
            dataTypeObj.SampleTypeCasting();
            dataTypeObj.SampleConverting();

            VariableUtils variableUtils = new VariableUtils();
            variableUtils.varibales();

            OperatorsUtils operatorsUtils = new OperatorsUtils();
            operatorsUtils.ArithmeticOperation();
            operatorsUtils.RelationalOperators();
            operatorsUtils.LogicalOperators();
            operatorsUtils.BitwiseOperator();
            operatorsUtils.AssignmentOperators();
            operatorsUtils.TernaryOperator();
            operatorsUtils.MiscellaneousOperators();

        }
    }
}
