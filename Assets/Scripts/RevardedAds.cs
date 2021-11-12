using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class RevardedAds : MonoBehaviour , IUnityAdsListener
{
    [SerializeField] private bool testMod = true;
    [SerializeField] private Button adsButton;

    private string gameId = "4446729";
    private string rewardedVideo = "Rewarded_Android";
    private void Start()
    {
        adsButton = GetComponent<Button>();
        adsButton.interactable = Advertisement.IsReady(rewardedVideo);
        if (adsButton)
        {
            adsButton.onClick.AddListener(ShowRewardedVideo);
            Advertisement.AddListener(this);
            Advertisement.Initialize(gameId, true);
        }
    }
    public void ShowRewardedVideo()
    {
        Advertisement.Show(rewardedVideo);
    }

    public void OnUnityAdsReady(string placementId)
    {
        if (placementId == rewardedVideo)
        {
            adsButton.interactable = true;
        }
    }
    public void OnUnityAdsDidError(string message)
    {
        //
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        //
    }
}
