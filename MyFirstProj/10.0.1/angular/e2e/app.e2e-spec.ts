import { MyFirstProjTemplatePage } from './app.po';

describe('MyFirstProj App', function() {
  let page: MyFirstProjTemplatePage;

  beforeEach(() => {
    page = new MyFirstProjTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
