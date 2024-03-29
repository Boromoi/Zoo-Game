﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        public GameObject lion, hippo, pig, tiger, zebra, sheep, bear;

        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.name = "henk";
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.name = "elsa";
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.name = "dora";
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.name = "wally";
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.name = "marty";
            Sheep molk = Instantiate(sheep, transform).GetComponent<Sheep>();
            molk.name = "molk";
            Bear mogly = Instantiate(bear, transform).GetComponent<Bear>();
            mogly.name = "mogly";
        }
    }
}
