using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFilterController : MonoBehaviour
{
    public static string[] colorBlindFilters = { "none", "deuteranopia", "protanopia", "tritanopia", "acromatopsia" };
    public static string colorBlindFilter => colorBlindFilters[colorBlindFilters.Length];
}
