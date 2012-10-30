PROJECT_ROOT=applifier-mobile/ios

all: Applifier.dll

libApplifierWrapper.a:
	ln -s ../ApplifierWrapper/Products/ApplifierWrapperBundle.framework/ApplifierWrapperBundle $@

Applifier.dll: applifier.cs AssemblyInfo.cs libApplifierWrapper.a extensions.cs
	/Developer/MonoTouch/usr/bin/btouch -e applifier.cs AssemblyInfo.cs -x=extensions.cs --out=$@ --link-with=libApplifierWrapper.a,libApplifierWrapper.a

clean:
	-rm -f *.a *dll
