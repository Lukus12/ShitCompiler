using ShitCompiler.CodeAnalysis.Lexicon;

namespace ShitCompiler.CodeAnalysis.Syntax.SyntaxNodes;

public sealed record VariableDeclarationSyntax(
    Lexeme Identifier,
    TypeClauseSyntax TypeClause,
    Lexeme SemicolonToken
): StatementSyntax(
    SyntaxKind.VariableDeclaration
) {

    public override IEnumerable<ISyntaxNode> GetChildren() {
        return new List<ISyntaxNode?>(){
            
            Identifier,
            TypeClause,
            SemicolonToken
        }.Where(n => n is not null)!;
    }

}