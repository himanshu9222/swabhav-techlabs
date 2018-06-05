package singletonpatternexample;

public abstract class Factory {
	protected abstract StatementType createStatements(String selection);
}
