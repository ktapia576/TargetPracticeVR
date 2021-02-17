using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabVelocityTracked : XRGrabInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        SetParentToXRRig();
        base.OnSelectEntered(args);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        SetParentToWorld();
        base.OnSelectExited(args);
    }

    public void SetParentToXRRig()
    {
        transform.SetParent(selectingInteractor.transform);
    }

    public void SetParentToWorld()
    {
        transform.SetParent(null);
    }
}