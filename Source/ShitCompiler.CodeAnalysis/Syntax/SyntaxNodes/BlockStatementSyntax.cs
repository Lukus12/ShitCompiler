using System.Collections.Immutable;
using ShitCompiler.CodeAnalysis.Lexicon;

namespace ShitCompiler.CodeAnalysis.Syntax.SyntaxNodes;

public sealed record BlockStatementSyntax(
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