Shader"Custom/Fresnel" {

    Properties {
        _MainTex ("Albedo", 2D) = "white" {}
        _Cutoff("Alpha Cutoff", Range(0, 1)) = 0.5
        _Color ("Color", Color) = (1, 1, 1, 1)
        _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelIntensity("Fresnel Intensity", Range(1, 10)) = 5
    }

    SubShader {
        Tags { "Queue"="Transparent Cutout" "RenderType"="Transparent Cutout" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _MainTex;
        fixed4 _Color;
        fixed4 _FresnelColor;
        float _FresnelIntensity;
        float _Cutoff;

        struct Input
        {
            float2 uv_MainTex;
            float3 viewDir;
        };
    
        void surf(Input IN, inout SurfaceOutput o)
        {
            //Albedo Texture
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;    
            //Fresnel effect
            o.Albedo = c.rgb;
            o.Alpha = c.a;
            o.Emission = _FresnelColor.rgb * pow(1 - dot(IN.viewDir, o.Normal), _FresnelIntensity);
            clip(o.Alpha - _Cutoff);
        }

        ENDCG
    }
    FallBack "Diffuse"
}