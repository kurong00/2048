Shader "Custom/Rectangle" {
	 Properties {
		_MainColor("Base (RGB)", Color) = (1,1,1,1)
		_RADIUSBUCE("_RADIUSBUCE",Range(0,0.5)) = 0.2
    }
    SubShader
    {
        pass
        {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "unitycg.cginc"
			float4 _MainColor;
			float _RADIUSBUCE;
			struct v2f
			{
				float4 pos : SV_POSITION ;
				float2 ModeUV: TEXCOORD0;
				float2 RadiusBuceVU : TEXCOORD1;
			};
			v2f vert(appdata_base v)
			{
				v2f o;
				o.pos=UnityObjectToClipPos(v.vertex);  //将模型顶点坐标转换到视图坐标矩阵中
				o.ModeUV=v.texcoord;   //获取模型的UV坐标
				o.RadiusBuceVU = v.texcoord - float2(0.5, 0.5);       //将模型UV坐标原点置为中心原点,为了方便计算
				return o;
			}
			fixed4 frag(v2f i):COLOR
			{
				fixed4 col;
				col = (0,1,1,0);
				if (abs(i.RadiusBuceVU.x)<0.5 - _RADIUSBUCE || abs(i.RadiusBuceVU.y)<0.5 - _RADIUSBUCE)    //即上面说的|x|<(0.5-r)或|y|<(0.5-r)
				{

					col = _MainColor;
				}
				else

				{
					if (length(abs(i.RadiusBuceVU) - float2(0.5 - _RADIUSBUCE, 0.5 - _RADIUSBUCE)) <_RADIUSBUCE)
					{
						col = _MainColor;
					}

					else

					{

						discard;

					}

				}
				return col;
			}
        ENDCG
        }
	}
	FallBack "Diffuse"
}
