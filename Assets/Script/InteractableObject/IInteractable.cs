namespace Script.InteractableObject
{
    public interface IInteractable
    {
        void Interactable();
        bool CanInteract();

        IInteractable ReturnObject();
    }
}