
SDKTestps.dll: dlldata.obj SDKTest_p.obj SDKTest_i.obj
	link /dll /out:SDKTestps.dll /def:SDKTestps.def /entry:DllMain dlldata.obj SDKTest_p.obj SDKTest_i.obj \
		kernel32.lib rpcndr.lib rpcns4.lib rpcrt4.lib oleaut32.lib uuid.lib \

.c.obj:
	cl /c /Ox /DWIN32 /D_WIN32_WINNT=0x0400 /DREGISTER_PROXY_DLL \
		$<

clean:
	@del SDKTestps.dll
	@del SDKTestps.lib
	@del SDKTestps.exp
	@del dlldata.obj
	@del SDKTest_p.obj
	@del SDKTest_i.obj
