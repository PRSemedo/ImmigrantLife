using UnityEngine;

public enum EventType 
{
    Dialogue,
    Choice,
    Animation,
}

[CreateAssetMenu(fileName = "NarrativeEvent", menuName = "Scriptable Objects/NarrativeEvents/NarrativeEvents")]
public abstract class NarrativeEvent : ScriptableObject
{
    /// <summary>
    /// Propriedade que indica o tipo de Entidade da inst�ncia.
    /// </summary>
    public virtual EventType Type { get => throw new System.Exception("A propriedade *Type* n�o foi implementada."); }

    /// <summary>
    /// O Evento Narrativo que vem a seguir deste.
    /// </summary>
    [SerializeField]
    public NarrativeEvent NextEvent;
}
