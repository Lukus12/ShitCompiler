using ShitCompiler.CodeAnalysis.Lexicon;
using ShitCompiler.CodeAnalysis.Syntax.SyntaxNodes;
using ShitCompiler.CodeAnalysis.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitCompiler.CodeAnalysis.Syntax.SyntaxNodes;


public sealed record CaseStatementSyntax(
    Lexeme BeginKeyword,
    ImmutableArray<StatementSyntax> Statements,
    Lexeme EndKeyword
) : StatementSyntax(SyntaxKind.BlockStatement)
{
    public override IEnumerable<ISyntaxNode> GetChildren()
    {
        return Enumerable
            .Concat<ISyntaxNode>(
                [BeginKeyword],
                Statements
            ).Concat(
                [EndKeyword]
            );
    }
}