//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ASM.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class ASMLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NUMBER=7, ADD=8, SUB=9, 
		MUL=10, MOD=11, DIV=12, CMP=13, TDC=14, PUSH=15, PUSHR=16, POP=17, JMP=18, 
		JNE=19, JEQ=20, JLT=21, JGT=22, JLE=23, JGE=24, DUP=25, NEG=26, LABEL=27, 
		WS=28, COMMENT=29;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "NUMBER", "ADD", "SUB", 
		"MUL", "MOD", "DIV", "CMP", "TDC", "PUSH", "PUSHR", "POP", "JMP", "JNE", 
		"JEQ", "JLT", "JGT", "JLE", "JGE", "DUP", "NEG", "LABEL", "WS", "COMMENT"
	};


	public ASMLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ASMLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'\r\n'", "':'", "'{'", "'}'", "'A'", "'B'", null, "'ADD'", "'SUB'", 
		"'MUL'", "'MOD'", "'DIV'", "'CMP'", "'TDC'", "'PUSH'", "'PUSHR'", "'POP'", 
		"'JMP'", "'JNE'", "'JEQ'", "'JLT'", "'JGT'", "'JLE'", "'JGE'", "'DUP'", 
		"'NEG'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "NUMBER", "ADD", "SUB", "MUL", 
		"MOD", "DIV", "CMP", "TDC", "PUSH", "PUSHR", "POP", "JMP", "JNE", "JEQ", 
		"JLT", "JGT", "JLE", "JGE", "DUP", "NEG", "LABEL", "WS", "COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ASM.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ASMLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1F', '\xB2', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x6', '\b', 'L', '\n', '\b', '\r', '\b', '\xE', '\b', 'M', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\a', '\x1C', 
		'\xA1', '\n', '\x1C', '\f', '\x1C', '\xE', '\x1C', '\xA4', '\v', '\x1C', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', 
		'\x3', '\x1E', '\a', '\x1E', '\xAC', '\n', '\x1E', '\f', '\x1E', '\xE', 
		'\x1E', '\xAF', '\v', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x2', '\x2', 
		'\x1F', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', 
		'\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '\x3', '\x2', '\a', '\x3', 
		'\x2', '\x32', ';', '\x3', '\x2', '\x43', '\\', '\x4', '\x2', '\x32', 
		';', '\x43', '\\', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', 
		'\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x2', '\xB4', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '=', '\x3', '\x2', '\x2', '\x2', '\x5', '@', 
		'\x3', '\x2', '\x2', '\x2', '\a', '\x42', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x44', '\x3', '\x2', '\x2', '\x2', '\v', '\x46', '\x3', '\x2', 
		'\x2', '\x2', '\r', 'H', '\x3', '\x2', '\x2', '\x2', '\xF', 'K', '\x3', 
		'\x2', '\x2', '\x2', '\x11', 'O', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'S', '\x3', '\x2', '\x2', '\x2', '\x15', 'W', '\x3', '\x2', '\x2', '\x2', 
		'\x17', '[', '\x3', '\x2', '\x2', '\x2', '\x19', '_', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x63', '\x3', '\x2', '\x2', '\x2', '\x1D', 'g', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', 'k', '\x3', '\x2', '\x2', '\x2', '!', 'p', 
		'\x3', '\x2', '\x2', '\x2', '#', 'v', '\x3', '\x2', '\x2', '\x2', '%', 
		'z', '\x3', '\x2', '\x2', '\x2', '\'', '~', '\x3', '\x2', '\x2', '\x2', 
		')', '\x82', '\x3', '\x2', '\x2', '\x2', '+', '\x86', '\x3', '\x2', '\x2', 
		'\x2', '-', '\x8A', '\x3', '\x2', '\x2', '\x2', '/', '\x8E', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x92', '\x3', '\x2', '\x2', '\x2', '\x33', '\x96', 
		'\x3', '\x2', '\x2', '\x2', '\x35', '\x9A', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\x9E', '\x3', '\x2', '\x2', '\x2', '\x39', '\xA5', '\x3', '\x2', 
		'\x2', '\x2', ';', '\xA9', '\x3', '\x2', '\x2', '\x2', '=', '>', '\a', 
		'\xF', '\x2', '\x2', '>', '?', '\a', '\f', '\x2', '\x2', '?', '\x4', '\x3', 
		'\x2', '\x2', '\x2', '@', '\x41', '\a', '<', '\x2', '\x2', '\x41', '\x6', 
		'\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\a', '}', '\x2', '\x2', '\x43', 
		'\b', '\x3', '\x2', '\x2', '\x2', '\x44', '\x45', '\a', '\x7F', '\x2', 
		'\x2', '\x45', '\n', '\x3', '\x2', '\x2', '\x2', '\x46', 'G', '\a', '\x43', 
		'\x2', '\x2', 'G', '\f', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\a', '\x44', 
		'\x2', '\x2', 'I', '\xE', '\x3', '\x2', '\x2', '\x2', 'J', 'L', '\t', 
		'\x2', '\x2', '\x2', 'K', 'J', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\x3', 
		'\x2', '\x2', '\x2', 'M', 'K', '\x3', '\x2', '\x2', '\x2', 'M', 'N', '\x3', 
		'\x2', '\x2', '\x2', 'N', '\x10', '\x3', '\x2', '\x2', '\x2', 'O', 'P', 
		'\a', '\x43', '\x2', '\x2', 'P', 'Q', '\a', '\x46', '\x2', '\x2', 'Q', 
		'R', '\a', '\x46', '\x2', '\x2', 'R', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'S', 'T', '\a', 'U', '\x2', '\x2', 'T', 'U', '\a', 'W', '\x2', '\x2', 
		'U', 'V', '\a', '\x44', '\x2', '\x2', 'V', '\x14', '\x3', '\x2', '\x2', 
		'\x2', 'W', 'X', '\a', 'O', '\x2', '\x2', 'X', 'Y', '\a', 'W', '\x2', 
		'\x2', 'Y', 'Z', '\a', 'N', '\x2', '\x2', 'Z', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '[', '\\', '\a', 'O', '\x2', '\x2', '\\', ']', '\a', 'Q', '\x2', 
		'\x2', ']', '^', '\a', '\x46', '\x2', '\x2', '^', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '_', '`', '\a', '\x46', '\x2', '\x2', '`', '\x61', '\a', 
		'K', '\x2', '\x2', '\x61', '\x62', '\a', 'X', '\x2', '\x2', '\x62', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\a', '\x45', '\x2', '\x2', 
		'\x64', '\x65', '\a', 'O', '\x2', '\x2', '\x65', '\x66', '\a', 'R', '\x2', 
		'\x2', '\x66', '\x1C', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\a', 'V', 
		'\x2', '\x2', 'h', 'i', '\a', '\x46', '\x2', '\x2', 'i', 'j', '\a', '\x45', 
		'\x2', '\x2', 'j', '\x1E', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\a', 
		'R', '\x2', '\x2', 'l', 'm', '\a', 'W', '\x2', '\x2', 'm', 'n', '\a', 
		'U', '\x2', '\x2', 'n', 'o', '\a', 'J', '\x2', '\x2', 'o', ' ', '\x3', 
		'\x2', '\x2', '\x2', 'p', 'q', '\a', 'R', '\x2', '\x2', 'q', 'r', '\a', 
		'W', '\x2', '\x2', 'r', 's', '\a', 'U', '\x2', '\x2', 's', 't', '\a', 
		'J', '\x2', '\x2', 't', 'u', '\a', 'T', '\x2', '\x2', 'u', '\"', '\x3', 
		'\x2', '\x2', '\x2', 'v', 'w', '\a', 'R', '\x2', '\x2', 'w', 'x', '\a', 
		'Q', '\x2', '\x2', 'x', 'y', '\a', 'R', '\x2', '\x2', 'y', '$', '\x3', 
		'\x2', '\x2', '\x2', 'z', '{', '\a', 'L', '\x2', '\x2', '{', '|', '\a', 
		'O', '\x2', '\x2', '|', '}', '\a', 'R', '\x2', '\x2', '}', '&', '\x3', 
		'\x2', '\x2', '\x2', '~', '\x7F', '\a', 'L', '\x2', '\x2', '\x7F', '\x80', 
		'\a', 'P', '\x2', '\x2', '\x80', '\x81', '\a', 'G', '\x2', '\x2', '\x81', 
		'(', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\a', 'L', '\x2', '\x2', 
		'\x83', '\x84', '\a', 'G', '\x2', '\x2', '\x84', '\x85', '\a', 'S', '\x2', 
		'\x2', '\x85', '*', '\x3', '\x2', '\x2', '\x2', '\x86', '\x87', '\a', 
		'L', '\x2', '\x2', '\x87', '\x88', '\a', 'N', '\x2', '\x2', '\x88', '\x89', 
		'\a', 'V', '\x2', '\x2', '\x89', ',', '\x3', '\x2', '\x2', '\x2', '\x8A', 
		'\x8B', '\a', 'L', '\x2', '\x2', '\x8B', '\x8C', '\a', 'I', '\x2', '\x2', 
		'\x8C', '\x8D', '\a', 'V', '\x2', '\x2', '\x8D', '.', '\x3', '\x2', '\x2', 
		'\x2', '\x8E', '\x8F', '\a', 'L', '\x2', '\x2', '\x8F', '\x90', '\a', 
		'N', '\x2', '\x2', '\x90', '\x91', '\a', 'G', '\x2', '\x2', '\x91', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\a', 'L', '\x2', '\x2', '\x93', 
		'\x94', '\a', 'I', '\x2', '\x2', '\x94', '\x95', '\a', 'G', '\x2', '\x2', 
		'\x95', '\x32', '\x3', '\x2', '\x2', '\x2', '\x96', '\x97', '\a', '\x46', 
		'\x2', '\x2', '\x97', '\x98', '\a', 'W', '\x2', '\x2', '\x98', '\x99', 
		'\a', 'R', '\x2', '\x2', '\x99', '\x34', '\x3', '\x2', '\x2', '\x2', '\x9A', 
		'\x9B', '\a', 'P', '\x2', '\x2', '\x9B', '\x9C', '\a', 'G', '\x2', '\x2', 
		'\x9C', '\x9D', '\a', 'I', '\x2', '\x2', '\x9D', '\x36', '\x3', '\x2', 
		'\x2', '\x2', '\x9E', '\xA2', '\t', '\x3', '\x2', '\x2', '\x9F', '\xA1', 
		'\t', '\x4', '\x2', '\x2', '\xA0', '\x9F', '\x3', '\x2', '\x2', '\x2', 
		'\xA1', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA0', '\x3', '\x2', 
		'\x2', '\x2', '\xA2', '\xA3', '\x3', '\x2', '\x2', '\x2', '\xA3', '\x38', 
		'\x3', '\x2', '\x2', '\x2', '\xA4', '\xA2', '\x3', '\x2', '\x2', '\x2', 
		'\xA5', '\xA6', '\t', '\x5', '\x2', '\x2', '\xA6', '\xA7', '\x3', '\x2', 
		'\x2', '\x2', '\xA7', '\xA8', '\b', '\x1D', '\x2', '\x2', '\xA8', ':', 
		'\x3', '\x2', '\x2', '\x2', '\xA9', '\xAD', '\a', '=', '\x2', '\x2', '\xAA', 
		'\xAC', '\n', '\x6', '\x2', '\x2', '\xAB', '\xAA', '\x3', '\x2', '\x2', 
		'\x2', '\xAC', '\xAF', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xAB', '\x3', 
		'\x2', '\x2', '\x2', '\xAD', '\xAE', '\x3', '\x2', '\x2', '\x2', '\xAE', 
		'\xB0', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xAD', '\x3', '\x2', '\x2', 
		'\x2', '\xB0', '\xB1', '\b', '\x1E', '\x2', '\x2', '\xB1', '<', '\x3', 
		'\x2', '\x2', '\x2', '\x6', '\x2', 'M', '\xA2', '\xAD', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}