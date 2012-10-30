//
//  ApplifierWrapper.m
//  ApplifierWrapper
//
//  Created by Nathan Curtis on 10/30/12.
//  Copyright (c) 2012 Three Rings Design. All rights reserved.
//

#import "ApplifierWrapper.h"

@implementation ApplifierWrapper

static bool featuredGamesReady = false;
static bool showFeaturedGamesImmediately = false;

+ (void)init:(NSString *)applifierID withWindow:(UIWindow *)window supportedOrientations:(UIDeviceOrientation)orientationsToSupport, ...
{
    NSLog(@"ApplifierWrapper.init in iOS");
    
    // Go through the va_args, init supported orientations
    NSMutableArray *orientations = [[NSMutableArray alloc] init];
    va_list args;
    va_start(args, orientationsToSupport);
    while (orientationsToSupport) {
        [orientations addObject:[NSNumber numberWithInt:orientationsToSupport]];
        orientationsToSupport = va_arg(args, UIDeviceOrientation);
    }
    va_end(args);
    
    [Applifier initWithApplifierID:applifierID withWindow:window supportedOrientationsArray:orientations];
    [Applifier sharedInstance].gameDelegate = ApplifierWrapper.wrapperSingleton;
    [[Applifier sharedInstance] prepareFeaturedGames];
    
    NSLog(@"initialized, preparing featured games");
}

+ (void)showFeaturedGames
{
    if (featuredGamesReady) {
        [[Applifier sharedInstance] showFeaturedGames];
        showFeaturedGamesImmediately = false;
    } else {
        showFeaturedGamesImmediately = true;
    }
}

- (void)applifierFeaturedGamesReady
{
    NSLog(@"applifierFeaturedGamesReady");
    featuredGamesReady = true;
    if (showFeaturedGamesImmediately) {
        NSLog(@"Showing featured games immediately");
        [ApplifierWrapper showFeaturedGames];
    }
}

- (void)applifierInterstitialReady
{
}

APPLIFIER_SINGLETON_FOR_CLASS(ApplifierWrapper, wrapperSingleton)

@end
