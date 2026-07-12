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

        DecisionMakingUtils decisionMakingUtils = new();
        decisionMakingUtils.IfStatement();
        decisionMakingUtils.SwitchStatement();
        decisionMakingUtils.NestedSwitchStatement();

        LoopsUtils loopsUtils = new();
        loopsUtils.ForLoop();
        loopsUtils.WileLoop();
        loopsUtils.ForLoop2();
        loopsUtils.DoWhileLoop();
        loopsUtils.BreakStatement();
        loopsUtils.ContinueStatement();
        loopsUtils.ContinueStatementInForLoop();
        loopsUtils.InfiniteLoop();
        loopsUtils.NestedForLoop();
        loopsUtils.NestedWhileLoops();
        loopsUtils.NestedDoWhileLoops();
        loopsUtils.FoorEachLoop();
        loopsUtils.ForeachWithArrays();
        loopsUtils.NestedForeachLoops();
        loopsUtils.ForeachWithLists();
        loopsUtils.ForeachWithDictionaries();
        loopsUtils.ForeachWithObjects();
        loopsUtils.IndexAccessForeach();

    }
}