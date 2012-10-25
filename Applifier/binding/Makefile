PROJECT_ROOT=applifier-mobile/ios

all: Applifier.dll

applifier-mobile:
	git clone git://github.com/Applifier/applifier-mobile.git

Applifier.a: applifier-mobile
	ln -s ${PROJECT_ROOT}/build/Release-iphoneos/Applifier.framework/Applifier $@

Applifier.dll: applifier.cs AssemblyInfo.cs Applifier.a extensions.cs
	/Developer/MonoTouch/usr/bin/btouch -e applifier.cs AssemblyInfo.cs -x=extensions.cs --out=$@ --link-with=Applifier.a,Applifier.a

clean:
	-rm -f *.a *dll
