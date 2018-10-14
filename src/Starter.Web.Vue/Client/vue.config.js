module.exports = {

    // Template for index.html
    //index: path.resolve(__dirname, '../wwwroot/index.html'),

    // Paths
    //assetsRoot: path.resolve(__dirname, '../wwwroot'),

    // outputDir: '../wwwroot',
    
    // configureWebpack: config => {

        
        
    //     //config.output.devtoolModuleFilenameTemplate = '[absolute-resource-path]';
    //     //config.output.devtoolFallbackModuleFilenameTemplate = '[absolute-resource-path]?[hash]';

    //     // output: {
    //     //     devtoolModuleFilenameTemplate: '[absolute-resource-path]',
    //     //     devtoolFallbackModuleFilenameTemplate: '[absolute-resource-path]?[hash]'
    //     // }
    // },
        
    // chainWebpack: config => {

    //     //config.plugins.delete('hmr');

    //    // disable generation of index.html to outputDir
    //    //config.plugins.delete('html');
    //    //config.plugins.delete('preload');
    //    //config.plugins.delete('prefetch');
    // }

     chainWebpack: config => {
         // If you wish to remove the standard entry point
         //config.entryPoints.delete('app');
         config.plugins.delete('hmr');
     }

};