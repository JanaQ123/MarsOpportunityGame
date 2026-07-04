Shader "Ultimate 10+ Shaders/Force Field Opaque"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        [HDR] _GlowColor ("Glow Color", Color) = (1,1,1,1)
        [HDR] _FillColor ("Fill Color", Color) = (0,0,1,1)

        _FresnelPower("Fresnel Power", Range(0, 10)) = 3
        _ScrollDirection ("Scroll Direction", float) = (0, 0, 0, 0)
        _MinOpacity("Min Opacity", Range(0, 1)) = 0.3
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "Queue"="Geometry" }
        LOD 100
        Cull Back
        Lighting Off
        ZWrite On

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            #ifndef SHADER_API_D3D11
                #pragma target 3.0
            #else
                #pragma target 4.0
            #endif

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                fixed3 normal : NORMAL;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float rim : TEXCOORD1;
                float4 position : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            fixed4 _GlowColor;
            fixed4 _FillColor;
            half _FresnelPower;
            half2 _ScrollDirection;
            half _MinOpacity;

            UNITY_INSTANCING_BUFFER_START(Props)
            UNITY_INSTANCING_BUFFER_END(Props)

            fixed3 viewDir;
            v2f vert (appdata vert)
            {
                v2f output;

                output.position = UnityObjectToClipPos(vert.vertex);
                output.uv = TRANSFORM_TEX(vert.uv, _MainTex);

                viewDir = normalize(ObjSpaceViewDir(vert.vertex));
                output.rim = 1.0 - saturate(dot(viewDir, vert.normal));

                output.uv += _ScrollDirection * _Time.y;

                return output;
            }

            fixed4 frag (v2f input) : SV_Target
            {
                fixed4 tex = tex2D(_MainTex, input.uv);

                fixed4 blended = lerp(_FillColor, _GlowColor * pow(_FresnelPower, input.rim), input.rim);

                fixed4 pixel = tex * blended;

                float rimBlend = max(input.rim, _MinOpacity);
                pixel = lerp(_FillColor * _MinOpacity, pixel, rimBlend);

                pixel.a = 1; // force fully opaque, ignore any alpha falloff

                return pixel;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}