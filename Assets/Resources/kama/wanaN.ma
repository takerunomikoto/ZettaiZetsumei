//Maya ASCII 2016 scene
//Name: wana2.ma
//Last modified: Sun, Nov 08, 2015 03:29:25 PM
//Codeset: UTF-8
requires maya "2016";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2016";
fileInfo "version" "2016";
fileInfo "cutIdentifier" "201502261600-953408";
fileInfo "osv" "Mac OS X 10.9.5";
fileInfo "license" "student";
createNode transform -n "pCube1";
	rename -uid "4C6D94B1-A943-7BEC-3156-2C953D43B8AE";
	setAttr ".s" -type "double3" 1 3.6072469062224051 0.41472376936343719 ;
createNode mesh -n "pCubeShape1" -p "pCube1";
	rename -uid "19A322B0-2547-421B-BA1B-B1B2B93761AE";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.69918918609619141 0.058907061815261841 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 9 ".pt";
	setAttr ".pt[4]" -type "float3" 0 -0.014720527 0 ;
	setAttr ".pt[5]" -type "float3" 0 -0.02208079 0 ;
	setAttr ".pt[18]" -type "float3" 0 0.0073602628 0 ;
	setAttr ".pt[19]" -type "float3" 0 0.014720527 0 ;
	setAttr ".pt[22]" -type "float3" 0.053100586 -0.02208079 0 ;
	setAttr ".pt[23]" -type "float3" 0 -0.051521845 0 ;
	setAttr ".pt[24]" -type "float3" 0 -0.029441055 2.7755576e-17 ;
	setAttr ".pt[25]" -type "float3" 0 -0.02208079 0 ;
	setAttr ".pt[26]" -type "float3" 0 -0.036801316 0 ;
createNode polySplit -n "polySplit12";
	rename -uid "88571769-8842-2B77-CF14-C4A022ECFD2D";
	setAttr ".e[0]"  0.484332;
	setAttr ".d[0]"  -2147483646;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit11";
	rename -uid "B6919594-B447-2818-437C-69A347C77191";
	setAttr ".e[0]"  0.62258202;
	setAttr ".d[0]"  -2147483628;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit10";
	rename -uid "E89DD580-9448-653A-BBC1-66A316F4D152";
	setAttr ".e[0]"  0.556086;
	setAttr ".d[0]"  -2147483630;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit9";
	rename -uid "3600AC38-D641-1672-6730-CF8E85C45BB2";
	setAttr ".e[0]"  0.46463799;
	setAttr ".d[0]"  -2147483616;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit8";
	rename -uid "B884C91F-8E4D-2AB5-EAFF-F0810E0679C9";
	setAttr ".e[0]"  0.41680601;
	setAttr ".d[0]"  -2147483615;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak6";
	rename -uid "A725BB79-1F4D-3921-F4CB-B2ADC7B43B18";
	setAttr ".uopa" yes;
	setAttr -s 10 ".tk";
	setAttr ".tk[0]" -type "float3" 0.16075712 0 0 ;
	setAttr ".tk[1]" -type "float3" -0.21044929 0 0 ;
	setAttr ".tk[2]" -type "float3" 0.16075712 0 0 ;
	setAttr ".tk[3]" -type "float3" -0.21044929 0 0 ;
	setAttr ".tk[10]" -type "float3" 0 0.05888211 0 ;
	setAttr ".tk[11]" -type "float3" 0 0.090683244 0 ;
	setAttr ".tk[18]" -type "float3" 0 0.026670465 0 ;
	setAttr ".tk[19]" -type "float3" 0 0.016002279 0 ;
	setAttr ".tk[20]" -type "float3" -0.065551169 0.031801142 -2.7755576e-17 ;
	setAttr ".tk[21]" -type "float3" -0.10102967 0.036344163 0 ;
createNode polySplit -n "polySplit7";
	rename -uid "56D00375-7A4D-8FC2-FFC2-F4891B183139";
	setAttr -s 2 ".e[0:1]"  0.22948 0.277217;
	setAttr -s 2 ".d[0:1]"  -2147483624 -2147483625;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak5";
	rename -uid "87927866-1343-2A0E-E468-DAB9FDC8CF26";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk";
	setAttr ".tk[11]" -type "float3" 0.54079723 0 0 ;
	setAttr ".tk[12]" -type "float3" -0.13110237 0 0 ;
	setAttr ".tk[13]" -type "float3" -0.13110243 0 0 ;
	setAttr ".tk[19]" -type "float3" 0.63912398 -0.063602284 0 ;
createNode polySplit -n "polySplit6";
	rename -uid "A714ADCD-EB40-D2FA-1442-C6B9C42A4BE3";
	setAttr ".e[0]"  0.491153;
	setAttr ".d[0]"  -2147483628;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak4";
	rename -uid "2091FBC0-614B-EA64-F91E-4E9886C84382";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[10]" -type "float3" -0.6063484 0.054516252 0 ;
	setAttr ".tk[14]" -type "float3" 0 0.031801142 0 ;
	setAttr ".tk[15]" -type "float3" 0 0.036344163 0 ;
	setAttr ".tk[17]" -type "float3" -3.7252903e-09 0 0 ;
	setAttr ".tk[18]" -type "float3" -0.45885828 -0.10448946 0 ;
createNode polySplit -n "polySplit5";
	rename -uid "FB6DA983-E749-DF23-2F1E-D0BB66FB5175";
	setAttr ".e[0]"  0.61026102;
	setAttr ".d[0]"  -2147483630;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit4";
	rename -uid "FB3C9FD0-2744-55C8-51E4-458AB5D98CB1";
	setAttr -s 2 ".e[0:1]"  0.70681101 0.71983302;
	setAttr -s 2 ".d[0:1]"  -2147483629 -2147483631;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak3";
	rename -uid "E9DBC5ED-DB48-DBAB-05BB-C4BCDD297ED5";
	setAttr ".uopa" yes;
	setAttr -s 16 ".tk[0:15]" -type "float3"  0 0 -0.2294074 0 0 -0.2294074
		 0 0 0.38127491 0 0 0.38127491 0 0 0.15186751 -2.7939677e-09 9.3132257e-10 0.15186745
		 0 0 -0.2294074 0 0 -0.2294074 0 0 0.38127491 0 0 0.38127491 0 0 -0.33579957 -2.7939677e-09
		 9.3132257e-10 -0.35389379 0 0 0.38127491 0 0 -0.2294074 0 0 -0.2294074 0 0 0.38127491;
createNode polyDelEdge -n "polyDelEdge3";
	rename -uid "5469741E-5E43-1A69-3927-4AA647002B3D";
	setAttr ".ics" -type "componentList" 1 "e[22]";
	setAttr ".cv" yes;
createNode polyDelEdge -n "polyDelEdge2";
	rename -uid "90E4B6BA-4848-CB96-63C7-61BE5414F8AD";
	setAttr ".ics" -type "componentList" 1 "e[27]";
	setAttr ".cv" yes;
createNode polyTweak -n "polyTweak2";
	rename -uid "518C8640-FF45-60F0-B8AE-5F9C4CCA2464";
	setAttr ".uopa" yes;
	setAttr -s 6 ".tk";
	setAttr ".tk[4]" -type "float3" 5.9604645e-08 0 0 ;
	setAttr ".tk[10]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".tk[11]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".tk[12]" -type "float3" -2.9802322e-08 0 0 ;
	setAttr ".tk[17]" -type "float3" -0.010498015 0 -5.5511151e-17 ;
	setAttr ".tk[18]" -type "float3" -0.026143754 0 -5.5511151e-17 ;
createNode polySplit -n "polySplit3";
	rename -uid "23428211-B747-571D-08E2-6DB888384882";
	setAttr -s 2 ".e[0:1]"  0.55959201 0.58685899;
	setAttr -s 2 ".d[0:1]"  -2147483630 -2147483628;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit2";
	rename -uid "0DAD6B65-B441-69FF-7E26-90AC021C6A0D";
	setAttr -s 2 ".e[0:1]"  0.55391997 0.56718898;
	setAttr -s 2 ".d[0:1]"  -2147483622 -2147483624;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyExtrudeFace -n "polyExtrudeFace2";
	rename -uid "2C899E60-C044-27AC-7F26-E993E7B1D483";
	setAttr ".ics" -type "componentList" 1 "f[3]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 3.6072469062224051 0 0 0 0 0.41472376936343719 0
		 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.5 -1.1993026 0 ;
	setAttr ".rs" 1560993173;
	setAttr ".lt" -type "double3" -2.4699537253878338e-16 -8.5595164906984531e-17 1.1141942322720984 ;
	setAttr ".ls" -type "double3" 1 1 1.0101877553789094 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 0.5 -1.8036233456068673 -0.20736188468171859 ;
	setAttr ".cbx" -type "double3" 0.5 -0.59498182955054035 0.20736188468171859 ;
createNode polyExtrudeFace -n "polyExtrudeFace1";
	rename -uid "7A53FC1E-694D-7FC3-4350-788542135728";
	setAttr ".ics" -type "componentList" 1 "f[4]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 3.6072469062224051 0 0 0 0 0.41472376936343719 0
		 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -0.5 -1.1993027 0 ;
	setAttr ".rs" 1094629926;
	setAttr ".lt" -type "double3" 2.4557388835226082e-16 -4.6653039487549964e-17 1.1069241529248428 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -0.50000005960464478 -1.8036234531112025 -0.20736188468171859 ;
	setAttr ".cbx" -type "double3" -0.5 -0.59498188330270796 0.20736188468171859 ;
createNode polyTweak -n "polyTweak1";
	rename -uid "4B98BFCC-F148-9EEB-F3E5-C69018CD76A8";
	setAttr ".uopa" yes;
	setAttr -s 6 ".tk";
	setAttr ".tk[1]" -type "float3" -5.9604645e-08 0 0 ;
	setAttr ".tk[4]" -type "float3" 0 0 0.42797276 ;
	setAttr ".tk[5]" -type "float3" 0 0 0.42797276 ;
	setAttr ".tk[7]" -type "float3" -5.9604645e-08 0 0 ;
	setAttr ".tk[8]" -type "float3" -5.9604645e-08 0 0 ;
	setAttr ".tk[11]" -type "float3" -5.9604645e-08 0 0 ;
createNode polyDelEdge -n "polyDelEdge1";
	rename -uid "79C11B46-C94C-9D69-7AD9-8585D0D0B562";
	setAttr ".ics" -type "componentList" 1 "e[0]";
	setAttr ".cv" yes;
createNode polySplit -n "polySplit1";
	rename -uid "8A593C39-EC4E-D129-70AB-31AF049207C1";
	setAttr -s 4 ".e[0:3]"  1 0 1 1;
	setAttr -s 4 ".d[0:3]"  -2147483648 -2147483648 -2147483648 -2147483645;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode deleteComponent -n "deleteComponent4";
	rename -uid "04CD218B-4F4C-E0D3-37CF-228F556A55BB";
	setAttr ".dc" -type "componentList" 0;
createNode deleteComponent -n "deleteComponent3";
	rename -uid "F660DD04-C34C-1FEA-C6B4-1B8EA0EE202A";
	setAttr ".dc" -type "componentList" 0;
createNode deleteComponent -n "deleteComponent2";
	rename -uid "5C45414B-B148-AF93-EB4C-4EA7A9CAD1A2";
	setAttr ".dc" -type "componentList" 0;
createNode deleteComponent -n "deleteComponent1";
	rename -uid "49385458-3F48-268F-32FE-25ABBBC2471C";
	setAttr ".dc" -type "componentList" 0;
createNode polySplitRing -n "polySplitRing1";
	rename -uid "CAD23EA6-6241-E899-B4EE-4C87E77CF7F5";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[4:5]" "e[8:9]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 3.6072469062224051 0 0 0 0 0.41472376936343719 0
		 0 0 0 1;
	setAttr ".wt" 0.33505925536155701;
	setAttr ".re" 5;
	setAttr ".sma" 29.999999999999996;
	setAttr ".p[0]"  0 0 1;
	setAttr ".fq" yes;
createNode polyCube -n "polyCube1";
	rename -uid "F2E1C4C7-994C-48A3-BDC5-09861CF478A8";
	setAttr ".cuv" 4;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "polySplit12.out" "pCubeShape1.i";
connectAttr "polySplit11.out" "polySplit12.ip";
connectAttr "polySplit10.out" "polySplit11.ip";
connectAttr "polySplit9.out" "polySplit10.ip";
connectAttr "polySplit8.out" "polySplit9.ip";
connectAttr "polyTweak6.out" "polySplit8.ip";
connectAttr "polySplit7.out" "polyTweak6.ip";
connectAttr "polyTweak5.out" "polySplit7.ip";
connectAttr "polySplit6.out" "polyTweak5.ip";
connectAttr "polyTweak4.out" "polySplit6.ip";
connectAttr "polySplit5.out" "polyTweak4.ip";
connectAttr "polySplit4.out" "polySplit5.ip";
connectAttr "polyTweak3.out" "polySplit4.ip";
connectAttr "polyDelEdge3.out" "polyTweak3.ip";
connectAttr "polyDelEdge2.out" "polyDelEdge3.ip";
connectAttr "polyTweak2.out" "polyDelEdge2.ip";
connectAttr "polySplit3.out" "polyTweak2.ip";
connectAttr "polySplit2.out" "polySplit3.ip";
connectAttr "polyExtrudeFace2.out" "polySplit2.ip";
connectAttr "polyExtrudeFace1.out" "polyExtrudeFace2.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace2.mp";
connectAttr "polyTweak1.out" "polyExtrudeFace1.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace1.mp";
connectAttr "polyDelEdge1.out" "polyTweak1.ip";
connectAttr "polySplit1.out" "polyDelEdge1.ip";
connectAttr "deleteComponent4.og" "polySplit1.ip";
connectAttr "deleteComponent3.og" "deleteComponent4.ig";
connectAttr "deleteComponent2.og" "deleteComponent3.ig";
connectAttr "deleteComponent1.og" "deleteComponent2.ig";
connectAttr "polySplitRing1.out" "deleteComponent1.ig";
connectAttr "polyCube1.out" "polySplitRing1.ip";
connectAttr "pCubeShape1.wm" "polySplitRing1.mp";
connectAttr "pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
// End of wana2.ma
