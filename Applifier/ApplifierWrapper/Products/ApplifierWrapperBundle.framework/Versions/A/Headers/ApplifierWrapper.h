//
//  ApplifierWrapper.h
//  ApplifierWrapper
//
//  Created by Nathan Curtis on 10/30/12.
//  Copyright (c) 2012 Three Rings Design. All rights reserved.
//

#import <Applifier/Applifier.h>

@interface ApplifierWrapper : NSObject <ApplifierGameDelegate>

+ (ApplifierWrapper *)wrapperSingleton;
+ (void)init:(NSString *)applifierID
  withWindow:(UIWindow *)window
supportedOrientations:(UIDeviceOrientation)orientationsToSupport, ...
NS_REQUIRES_NIL_TERMINATION;

+ (void)showFeaturedGames;

@end
