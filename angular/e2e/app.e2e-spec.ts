import { ABCCommunityTemplatePage } from './app.po';

describe('ABCCommunity App', function() {
  let page: ABCCommunityTemplatePage;

  beforeEach(() => {
    page = new ABCCommunityTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
