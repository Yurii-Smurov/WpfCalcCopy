﻿using WpfApp1.Interfaces;

namespace WpfApp1.Services
{
    /// <summary>
    /// Реализация калькулятора, использующая токенизатор, парсер и вычислитель
    /// </summary>
    public class Calculator : ICalculator
    {
        private readonly ITokenizer _tokenizer;
        private readonly IParser _parser;
        private readonly IEvaluator _evaluator;

        public Calculator(ITokenizer tokenizer, IParser parser, IEvaluator evaluator)
        {
            _tokenizer = tokenizer;
            _parser = parser;
            _evaluator = evaluator;
        }

        public double Calculate(string expression)
        {
            // Токенизация строки выражения
            var tokens = _tokenizer.Tokenize(expression);
            // Парсинг токенов в AST
            var ast = _parser.Parse(tokens);
            // Вычисление значения выражения
            return _evaluator.Evaluate(ast);
        }
    }
}
