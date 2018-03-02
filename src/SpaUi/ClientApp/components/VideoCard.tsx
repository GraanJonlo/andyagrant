import * as React from 'react';
import { Link } from 'react-router-dom';

interface VideoCardProps {
    id: string,
    title: string,
    summary: string,
    image: string,
    timestamp: string
}

interface VideoCardState {
    image: string,
    img: HTMLImageElement
}

export class VideoCard extends React.Component<VideoCardProps, VideoCardState> {
    constructor(props: VideoCardProps) {
        super(props);
    }

    public render() {
        return <div className='card'>
                    <Link to={'/videopost/' + this.props.id}>
                        <div className="card-image">
                            <figure className="image is-16by9">
                                <img src={this.props.image} className='imgPlaceholder' alt={this.props.title} />
                            </figure>
                        </div>
                    </Link>
                    <div className='card-content'>
                        <h2 className='title is-4'>{this.props.title}</h2>
                        <div className='content' dangerouslySetInnerHTML={({__html: this.props.summary})}></div>
                        <p><time dateTime={this.props.timestamp}>{this.props.timestamp}</time></p>
                    </div>
                </div>
    }
}