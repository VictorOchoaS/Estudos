﻿
let fim_console() =
    printfn ""
    printfn "Fim da Aplicação"
    0

let Executar_funcao f =
    printfn ""
    f()
    printfn ""

[<EntryPoint>]
let main argv =

    //printfn "Valores"
    //Executar_funcao Valores.exibir_PI
    //Executar_funcao Valores.mutabilidade
    //printfn "Funções"
    //Executar_funcao Func.fazendo_funcao_soma
    //Executar_funcao Func.fazendo_funcao_resursiva
    //Executar_funcao Func.expressao_lambda
    //Executar_funcao Func.inicio_pipiline
    //Executar_funcao Func.unindo_funcoes
    //Executar_funcao Func.ordem_Execut
    //printfn "Matematica"
    //Executar_funcao Matematica.matematica_basica
    //Executar_funcao Matematica.tipo_valor
    //printfn "String"
    //Executar_funcao StringFunc.exibir_resultados
    //printfn "Loop"
    //Executar_funcao Loop.loop_while
    //Executar_funcao Loop.loop_for
    //printfn "Condicionais"
    //Executar_funcao Condicionais.cond_if
    //printfn "Listas"
    //Executar_funcao Lista.lista
    //printfn "Enum"
    //Executar_funcao EnumStuff.enum_stuff
    //printfn "Option"
    //Executar_funcao OptionStuff.divisao_0
    //printfn "Tuple"
    //Executar_funcao TupleStuff.tupleReturn
    //printfn "Record"
    //Executar_funcao RecordStuff.record_stuff
    //printfn "Sequence"
    //Executar_funcao SequencesStuff.seq_stuff
    //printfn "Map"
    //Executar_funcao MapStuff.map_stuff
    //printfn "Generic"
    //Executar_funcao GenericStuff.generic_stuff
    //printfn "Exception"
    //Executar_funcao Exp.exp_stuff
    //printfn "Struct"
    //Executar_funcao StructStuff.struct_stuff
    printfn "Class"
    Executar_funcao ClassStuff.class_stuff

    fim_console()
