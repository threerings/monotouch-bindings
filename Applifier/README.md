Applifier
========

These are extremely simple bindings to the native Applifier API for iOS. There
is something tricky going on making it difficult to get the delegate to work
across the C#/Obj-C boundary. So, there is now an ApplifierWrapper iOS framework
in ApplifierWrapper. That framework handles the delegate, and currently exposes
only one piece of functionality: showFeaturedGames.

Using
=====

TODO

Building
========

To build ApplifierWrapper, run make applifier-mobile in this directory, then
open the project in XCode. There is an included build checked in at
ApplifierWrapper/Products/ApplifierWrapperBundle.framework.

Run `make' in the binding directory to build Applifier.dll. This does not
require a fresh build of the wrapper framework.

Sample
======

TODO

There is some incomplete sample code in the sample directory for reference.

License
=======

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.


Authors
=======

Nathan Curtis
