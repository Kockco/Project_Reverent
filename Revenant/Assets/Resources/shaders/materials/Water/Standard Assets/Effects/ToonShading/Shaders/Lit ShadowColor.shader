﻿Shader "Toon/Lit ShadowColor" {
	Properties{
		_Color("Main Color", Color) = (0.5,0.5,0.5,1)
		_MainTex("Base (RGB)", 2D) = "white" {}
		_Ramp("Toon Ramp (RGB)", 2D) = "gray" {}

	}

		SubShader{
			LOD 200
			Cull Off

	CGPROGRAM
	#pragma surface surf ToonRamp fullforwardshadows // allows multiple lights

	sampler2D _Ramp;
	uniform float4 _ShadowColor;
	uniform float _ShadowStrength;

	// custom lighting function that uses a texture ramp based
	// on angle between light direction and normal
	#pragma lighting ToonRamp

	inline half4 LightingToonRamp(SurfaceOutput s, half3 lightDir, half atten)
	{
		#ifndef USING_DIRECTIONAL_LIGHT
		lightDir = normalize(lightDir);
		#endif

		half d = dot(s.Normal, lightDir)*0.5 + 0.5;
		half3 ramp = tex2D(_Ramp, float2(d,d)).rgb;

		half4 c;

		c.rgb = s.Albedo * _LightColor0.rgb * ramp * (atten * 2);
		c.rgb = lerp(c.rgb , (_ShadowColor - _ShadowStrength),1 - (atten)); //lerp between texture and shadow color, based on 1- light attenuation
		c.a = 0;
		return c;
	}


	sampler2D _MainTex;
	float4 _Color;

	struct Input {
		float2 uv_MainTex : TEXCOORD0;
	};

	void surf(Input IN, inout SurfaceOutput o) {
		half4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
		o.Albedo = c.rgb;
		o.Alpha = c.a;
	}
	ENDCG

	}



		Fallback "Diffuse"
}