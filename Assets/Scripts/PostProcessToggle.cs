using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessToggle : MonoBehaviour
{
    [SerializeField] private PostProcessVolume _postprocessVolume;
    private Bloom _bloom;
    private ChromaticAberration _chromaticAberation;

    public Rigidbody2D rb;

    private void Start()
    {
        _postprocessVolume.profile.TryGetSettings(out _chromaticAberation);
        _postprocessVolume.profile.TryGetSettings(out _bloom);
        rb.constraints = RigidbodyConstraints2D.None;
    }

    void Update()
    {
        if (SettingsMenu.PostProcessOn)
        {
            _bloom.active = true;
            _chromaticAberation.active = true;
        }
        else
        {
            _bloom.active = false;
            _chromaticAberation.active = false;
        } 
    }
}
