using System;
using System.Collections.Generic;

namespace AsmHelper.DataProvider
{
    public enum UsefulInstructionType
    {
        DataMovement,
        DataCalculation,
        BitShift,
        CompareAndJump,
        LoopAndCall,
    }

    public enum AdvancedInstructionType
    {
        DataMovement,
        IORelated,
        DataCalculation,
        DataAdjustment,
        BitShift,
        BunchTransfer,
        CompareAndLoop,
        CompareAndJump,
        CPUControl,
    }

    public static class GetInstructions
    {
        public static readonly Dictionary<UsefulInstructionType, Dictionary<string, string>> UsefulInstructionDictionary =
            new Dictionary<UsefulInstructionType, Dictionary<string, string>>
            {
                {
                    UsefulInstructionType.DataMovement, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"MOV",""},
                        {"PUSH",""},
                        {"POP",""},
                        {"LEA",""},
                        {"LDS",""},
                        {"LES",""},
                    }
                },
                {
                    UsefulInstructionType.DataCalculation, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"ADD",""},
                        {"ADC",""},
                        {"INC",""},
                        {"SUB",""},
                        {"SBB",""},
                        {"DEC",""},
                        {"MUL",""},
                        {"IMUL",""},
                        {"DIV",""},
                        {"IDIV",""},
                    }
                },
                {
                    UsefulInstructionType.BitShift, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"AND",""},
                        {"OR",""},
                        {"NOT",""},
                        {"XOR",""},
                        {"SHL",""},
                        {"SHR",""},
                        {"SAL",""},
                        {"SAR",""},
                    }
                },
                {
                    UsefulInstructionType.CompareAndJump, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"CMP",""},
                        {"JMP",""},
                        {"JE",""},
                        {"JNE",""},
                        {"JB",""},
                        {"JNB",""},
                        {"JA",""},
                        {"JNA",""},
                        {"JL",""},
                        {"JNL",""},
                        {"JG",""},
                        {"JNG",""},
                    }
                },
                {
                    UsefulInstructionType.LoopAndCall, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"CALL",""},
                        {"RET",""},
                        {"INT",""},
                        {"NOP",""},
                        {"LOOP",""},
                        {"LOOPE",""},
                        {"LOOPNE",""},
                    }
                },
            };

        public static readonly Dictionary<AdvancedInstructionType, Dictionary<string, string>> AdvancedInstructionDictionary =
            new Dictionary<AdvancedInstructionType, Dictionary<string, string>>
            {
                {
                    AdvancedInstructionType.DataMovement, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"PUSHF",""},
                        {"POPF",""},
                        {"XCHG",""},
                        {"XLAT",""},
                    }
                },
                {
                    AdvancedInstructionType.IORelated, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"IN",""},
                        {"OUT",""},
                    }
                },
                {
                    AdvancedInstructionType.DataCalculation, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"NEG",""},
                    }
                },
                {
                    AdvancedInstructionType.DataAdjustment, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"CBW",""},
                        {"CWD",""},
                        {"DAA",""},
                        {"DAS",""},
                        {"AAA",""},
                        {"AAS",""},
                        {"AAM",""},
                        {"AAD",""},
                    }
                },
                {
                    AdvancedInstructionType.BitShift, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"ROL",""},
                        {"ROR",""},
                        {"RCL",""},
                        {"RCR",""},
                    }
                },
                {
                    AdvancedInstructionType.BunchTransfer, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"MOVSB",""},
                        {"MOVSW",""},
                        {"MOVS",""},
                        {"LODSB",""},
                        {"LODSW",""},
                        {"LODS",""},
                        {"STOSB",""},
                        {"STOSW",""},
                        {"STOS",""},
                    }
                },
                {
                    AdvancedInstructionType.CompareAndLoop, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"CMPS",""},
                        {"SCAS",""},
                        {"REP",""},
                        {"REPE",""},
                        {"REPNE",""},
                    }
                },
                {
                    AdvancedInstructionType.CompareAndJump, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"TEST",""},
                        {"JS",""},
                        {"JNS",""},
                        {"JO",""},
                        {"JNO",""},
                        {"JP",""},
                        {"JNP",""},
                        {"JC",""},
                        {"JNC",""},
                    }
                },
                {
                    AdvancedInstructionType.CPUControl, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                    {
                        {"CLC",""},
                        {"STC",""},
                        {"CMC",""},
                        {"CLD",""},
                        {"STD",""},
                        {"CLI",""},
                        {"STI",""},
                        {"HLT",""},
                        {"WAIT",""},
                        {"LOCK",""},
                        {"ESC",""},
                    }
                },
            };
    }
}
