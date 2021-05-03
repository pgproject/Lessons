namespace Script.InteractableObject
{
    public interface IInteractable
    {
        void Interact();
        bool CanInteract();

        IInteractable ReturnObject();

        bool InteractWithButton();
    }
}