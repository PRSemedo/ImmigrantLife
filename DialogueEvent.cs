using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe que representa um Di�logo entre pelo menos duas Personagens.
/// </summary>
[CreateAssetMenu(fileName = "ScriptableDialogue", menuName = "Scriptable Objects/ScriptableDialogue")]
public class DialogueEvent : NarrativeEvent
{
    //lista de dialogos por cena
    public List<DialogueBlock> dialogueList = new List<DialogueBlock>();

    public override void StartEvent() { }

    public override void EndEvent() { }
}


/// <summary>
/// Classe que representa um Bloco (unidade) do com dialogo.
/// Um Dialogo � formado por uma lista de Blocos.
/// </summary>
[System.Serializable]
public class DialogueBlock
{
    /// <summary>
    /// Personagem que representa o emissor da Frase ao qual este Bloco se refere.
    /// </summary>
    public CharacterScriptable Speaker;

    /// <summary>
    /// A Frase (texto) que � dita neste Bloco.
    /// </summary>
    [TextArea(2, 20)]
    public string Sentence;
}